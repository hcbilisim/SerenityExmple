using MyRequest = SerenityExmple.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenityExmple.Administration.UserRow>;
using MyRow = SerenityExmple.Administration.UserRow;

namespace SerenityExmple.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}