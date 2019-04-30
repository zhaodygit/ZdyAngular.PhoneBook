
using AutoMapper;
using ZdyAngular.PhoneBook.PhoneBooks.Persons;
using ZdyAngular.PhoneBook.PhoneBooks.Persons.Dtos;

namespace ZdyAngular.PhoneBook.PhoneBooks.Persons.Mapper
{

	/// <summary>
    /// 配置Person的AutoMapper
    /// </summary>
	internal static class PersonMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Person,PersonListDto>();
            configuration.CreateMap <PersonListDto,Person>();

            configuration.CreateMap <PersonEditDto,Person>();
            configuration.CreateMap <Person,PersonEditDto>();

        }
	}
}
