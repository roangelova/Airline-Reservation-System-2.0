
using ARS.Common.DTOs.CrewMember;

namespace ARS.Service.Contracts
{
    public interface ICrewMemberService
    {
        public Task AddCrewMember(AddCrewMemberDTO addCrewMemberDTO);
    }
}
