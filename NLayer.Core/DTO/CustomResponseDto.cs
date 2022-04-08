using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTO
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }
        [JsonIgnore ]
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }
        //static metodlar factory design patterndan gelir. Static Factory Methods.
        public static CustomResponseDto<T> Success(int statusCode,T data)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Data = data};
        }
        //data dönmeyecek durumlar için, örn: addproduct
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode };
        }
        public static CustomResponseDto<T> Fail(int statusCode,List<string> errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = null };
        }
        //Yalnızca 1 hata gelme durumu için
        public static CustomResponseDto<T> Fail(int statusCode, string error)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
