using Models.Enumerations;

namespace Reactivities.Common.Result.Models;

public class Result<T>
{
    public Result()
    { }

    public Result(T data, ResultType type, bool isSuccessful = false, string message = null)
    {
        this.Data = data;
        this.ResultType = type;
        this.Message = message ?? string.Empty;
        this.IsSuccessful = isSuccessful;
    }

    public bool IsSuccessful { get; set; }

    public T Data { get; set; }

    public string Message { get; set; }

    public ResultType ResultType { get; set; }

    public static Result<T> Success(T data, string message = null) => new(data, ResultType.Success, true, message);

    public static Result<T> Failure(string message = null) => new(default, ResultType.Failure, false, message);

    public static Result<T> NotFound(string message = null) => new(default, ResultType.NotFound, false, message);
     
    public static Result<T> Unauthorized(string message = null) => new(default, ResultType.Unauthorized, false, message);

    public static Result<T> New(T data, ResultType type, bool isSuccessful, string message) => new(data, type, isSuccessful, message);
}