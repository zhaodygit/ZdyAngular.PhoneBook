
using Abp.Runtime.Validation;
using ZdyAngular.PhoneBook.Dtos;
using ZdyAngular.PhoneBook.PhoneBooks.Persons;

namespace ZdyAngular.PhoneBook.PhoneBooks.Persons.Dtos
{
    public class GetPersonsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
