namespace idflApp.Core.Dtos
{
    public class GetBookFormResponseDto
    {
        public string Id { get; set; }  
        public string? Client { get; set; }
        public string? Standard { get; set; }
        public string? Status { get; set; }
        public List<GetFactoryResponseDto>? Factories { get; set; }
    }
    public class GetFactoryResponseDto{
        public string Id { get; set; }  
        public string UnitName { get; set; }
    }
    public class UserResponseDto{
        public string Id { get; set; }
        public string Name { get; set; }
    }
}