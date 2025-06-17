using MyRequest = Serenity.Services.SaveRequest<SerenityExmple.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenityExmple.Administration.LanguageRow;


namespace SerenityExmple.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}