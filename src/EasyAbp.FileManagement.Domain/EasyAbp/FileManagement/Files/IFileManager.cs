﻿using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Volo.Abp.Domain.Services;

namespace EasyAbp.FileManagement.Files
{
    public interface IFileManager : IDomainService
    {
        Task<File> CreateAsync([NotNull] string fileContainerName, [NotNull] string fileName,
            [CanBeNull] string mimeType, FileType fileType, Guid? parentId, byte[] fileContent);

        Task<File> UpdateAsync(File file, [NotNull] string newFileName);
        
        Task<File> UpdateAsync(File file, [NotNull] string newFileName, [CanBeNull] string newMimeType, byte[] newFileContent);

        Task SaveBlobAsync(File file, byte[] fileContent, bool overrideExisting = false);
    }
}