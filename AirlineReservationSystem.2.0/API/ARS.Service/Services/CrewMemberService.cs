
using ARS.Common.DTOs.CrewMember;
using ARS.Common.Entities;
using ARS.Common.Enums;
using ARS.Persistance.UnitOfWork;
using ARS.Service.Contracts;

namespace ARS.Service.Services
{
    public class CrewMemberService : ICrewMemberService
    {
        private readonly IUnitOfWork unitOfWork;

        public CrewMemberService(
            IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task AddCrewMember(AddCrewMemberDTO addCrewMemberDTO)
        {
            try
            {
                var crewMember = new CrewMember
                {
                    Name = addCrewMemberDTO.Name,
                    CrewType = Enum.Parse<CrewType>(addCrewMemberDTO.CrewType),
                    TypeRating = Enum.Parse<AircraftType>(addCrewMemberDTO.TypeRating),
                    AvatarUrl = addCrewMemberDTO?.AvatarUrl,
                    AirlineId = Guid.Parse(addCrewMemberDTO.AirlineId)
                };


                await unitOfWork.CrewMembers.AddAsync(crewMember);
                await unitOfWork.CompleteAsync();

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
