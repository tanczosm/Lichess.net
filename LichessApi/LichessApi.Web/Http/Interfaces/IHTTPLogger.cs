namespace LichessApi.Web.Http
{
  public interface IHTTPLogger
  {
    void OnRequest(IRequest request);
    void OnResponse(IResponse response);
  }
}
