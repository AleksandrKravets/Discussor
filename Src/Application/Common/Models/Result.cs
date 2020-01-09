namespace Discussor.Core.Application.Common.Models
{
    public class Result
    {
        public bool Success { get; private set; }

        protected Result(bool success) { }

        public static Result Fail() 
        {
            return new Result(false);
        }

        public static Result Ok() 
        {
            return new Result(true);
        }
    }

    public class Result<T> : Result
    {
        public T Value { get; set; }

        protected internal Result(bool success, T value)
            : base(success)
        {
            this.Value = value;
        }

        public static Result<T> Fail(T value)
        {
            return new Result<T>(false, value);
        }

        public static Result<T> Ok(T value) 
        {
            return new Result<T>(true, value);
        }
    }
}
