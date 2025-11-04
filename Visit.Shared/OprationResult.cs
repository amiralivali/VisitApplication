namespace Visit.Shared
{
    public class OprationResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public static OprationResult Success(string message="")
        {
            string text = Messages.Success;
            text = string.Format(text, message);
            return new OprationResult()
            {
                IsSuccess = true,
                Message = text
            };
        }
        public static OprationResult Duplicate(string message)
        {
            string text = Messages.Duplicate;
            text = string.Format(text, message);
            return new OprationResult()
            {
                IsSuccess = false,
                Message = text
            };
        }
        public static OprationResult UnSuccess(string message="")
        {
            return new OprationResult()
            {
                IsSuccess = false,
                Message = message
            };
        }
        public static OprationResult RunTimeError()
        {
            return new OprationResult()
            {
                IsSuccess = false,
                Message = Messages.RunTimeError
            };
        }
    }
    public class OprationResult<T> : OprationResult
    {
        public T Data { get; set; }
        public static OprationResult<T> Success(T data, string message="")
        {
            string text = Messages.Success; 
            if (message != null)
            {
                text = string.Format(text, message);
            }
            return new OprationResult<T>()
            {
                IsSuccess = true,
                Data = data,
                Message=text
            };
        }
        public new static OprationResult<T> RunTimeError()
        {
            return new OprationResult<T>()
            {
                IsSuccess = false,
                Message = Messages.RunTimeError
            };
        }
    }
}