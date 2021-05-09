namespace Application.Core
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public T Value { get; set; } // The course uses this property
        public T Data { get; set; } // I prefer this property (Because of SwiftUI)
        public string Error { get; set; }
        public static Result<T> Success(T data) => new Result<T> { IsSuccess = true, Data = data };
        public static Result<T> Failure(string error) => new Result<T> { IsSuccess = false, Error = error };
    }
}