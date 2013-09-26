using Pos.Core.Enums;

namespace Pos.Core.Interfaces
{
    public interface IUserRole
    {
        string Title { get; set; }
        UserInRole UserInRole { get; set; }
        int Id { get; set; }
    }
}