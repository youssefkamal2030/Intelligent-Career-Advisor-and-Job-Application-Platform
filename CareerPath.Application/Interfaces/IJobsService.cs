﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CareerPath.Contracts.Dto;

namespace CareerPath.Application.Interfaces
{
    public interface IJobsService
    {
        Task<JobDto> GetJobByIdAsync(string id);
        Task<IEnumerable<JobDto>> GetAllJobsAsync();
        Task<IEnumerable<JobDto>> GetJobsByUserIdAsync(string userId);
      
    }
}
