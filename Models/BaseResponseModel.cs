using System.Net;

namespace CoreDataProtectionTutorial.Models
{
    public class BaseResponseModel<T> where T : class
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public static BaseResponseModel<T> returnSuccess(T data)
        {
            return new BaseResponseModel<T>
            {
                Data = data,
                StatusCode = HttpStatusCode.OK,
                Message = "Success"
            };
        }
        public static BaseResponseModel<T> returnError(T data, string message)
        {
            return new BaseResponseModel<T>
            {
                Data = data,
                StatusCode = HttpStatusCode.BadRequest,
                Message = message
            };
        }

    }
}