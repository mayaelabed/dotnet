namespace dotnet_project.Models.DTO
{
    public class Status
    {
       
        
            public int StatusCode { get; set; }
            public string? Message { get; set; }
        public bool Succeeded { get; internal set; }
        public IEnumerable<object> Errors { get; internal set; }
    }
    
}
