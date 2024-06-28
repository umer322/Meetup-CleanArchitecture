using Core.Common;
using Core.Interfaces;

namespace Core.Enitites.MeetingGroup;

public class MeetingGroup : AuditableEntity,IAggregateRoot{
    public long OrganizerId {get; private set;}
    public string Title {get; private set;}
    public string? Description {get; private set;}
    private IList<Meeting> meetings = [];
    public IReadOnlyCollection<Meeting> Meetings => meetings.AsReadOnly();
    private IList<Member> members = [];

    public IReadOnlyCollection<Member> Members => members.AsReadOnly();

    private MeetingGroup(){}

    public MeetingGroup(string Title,string? Description,long? OrganizerId){

    }
}