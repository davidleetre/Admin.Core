﻿using ZhonTai.Common.Domain.Dto;
using System.Threading.Tasks;
using ZhonTai.Plate.Admin.Service.Dictionary.Input;
using ZhonTai.Plate.Admin.Domain.Dictionary.Dto;

namespace ZhonTai.Plate.Admin.Service.Dictionary
{
    public partial interface IDictionaryService
    {
        Task<IResultOutput> GetAsync(long id);

        Task<IResultOutput> GetPageAsync(PageInput<DictionaryGetPageDto> input);

        Task<IResultOutput> AddAsync(DictionaryAddInput input);

        Task<IResultOutput> UpdateAsync(DictionaryUpdateInput input);

        Task<IResultOutput> DeleteAsync(long id);

        Task<IResultOutput> SoftDeleteAsync(long id);

        Task<IResultOutput> BatchSoftDeleteAsync(long[] ids);
    }
}