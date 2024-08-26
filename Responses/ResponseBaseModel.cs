namespace ODISApi.Responses
{
    public class ResponseBaseModel<T>
    {
        public T Payload { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; }
    }
}
