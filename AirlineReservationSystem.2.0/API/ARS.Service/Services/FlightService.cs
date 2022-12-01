using ARS.Common.Constants.ErrorConstants;
using ARS.Common.DTOs.Flight;
using ARS.Common.Entities;
using ARS.Common.Enums;
using ARS.Persistance.UnitOfWork;
using ARS.Service.Contracts;

namespace ARS.Service.Services
{
    public class FlightService : IFlightService
    {
        private readonly IUnitOfWork unitOfWork;

        public FlightService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task CreateFlights(AddFlightDTO addFlightDTO)
        {
            try
            {
                var aircraft = await unitOfWork.Aircraft.GetByIdAsync(addFlightDTO.AircraftId);
                var airline = await unitOfWork.Airlines.GetByIdAsync(addFlightDTO.AirlineId);
                var captain = await unitOfWork.CrewMembers.GetByIdAsync(addFlightDTO.CaptainId);
                var firstOfficer = await unitOfWork.CrewMembers.GetByIdAsync(addFlightDTO.FirstOfficerId);

                if(addFlightDTO.DestinationId == addFlightDTO.OriginId)
                {
                    throw new Exception(ErrorMessageConstants.Invalid_flight_data_);
                }


                if (aircraft.AirlineId != airline.AirlineId)
                {
                    throw new Exception(string.Concat(ErrorMessageConstants.Aircraft_or_crewmember_does_not_belong_to_Airline_, nameof(Aircraft)));
                }

                if(firstOfficer.TypeRating != aircraft.Manufacturer)
                {
                    throw new Exception(string.Concat(ErrorMessageConstants.Type_rating_missmatch_, firstOfficer.CrewMemberId));
                }

                if (captain.TypeRating != aircraft.Manufacturer)
                {
                    throw new Exception(string.Concat(ErrorMessageConstants.Type_rating_missmatch_, captain.CrewMemberId));
                }

                int CountOfFlightAttendants = addFlightDTO.FlightAttendants.Count;


                switch (aircraft.Capacity)
                {
                    case <= 180:
                        if(CountOfFlightAttendants < 4)
                        {
                            throw new Exception(string.Concat(ErrorMessageConstants.Count_Of_Flight_Attendants_not_enough, 4));
                        }
                        break;
                    case <= 240:
                        if (CountOfFlightAttendants < 8)
                        {
                            throw new Exception(string.Concat(ErrorMessageConstants.Count_Of_Flight_Attendants_not_enough, 8));
                        }
                        break;
                    default:
                        if (CountOfFlightAttendants < 2)
                        {
                            throw new Exception(string.Concat(ErrorMessageConstants.Count_Of_Flight_Attendants_not_enough, 2));
                        }
                        break;
                }


                var flight = new Flight
                {
                    AirlineId = addFlightDTO.AirlineId,
                    AircraftID = addFlightDTO.AircraftId,
                    OriginId = addFlightDTO.OriginId,
                    DestinationId = addFlightDTO.DestinationId,
                    AvailableCapacity = aircraft.Capacity,
                    TakeOffTime = addFlightDTO.TakeOffTime,
                    Duration = addFlightDTO.Duration,
                    IsAnOffer = false,
                    FlightStatus = FlightStatus.Planned,
                    TicketPrice = addFlightDTO.TicketPrice
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
