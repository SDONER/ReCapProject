using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        static string directory = Environment.CurrentDirectory + @"\wwwroot\";
        static string folderName = "\\images\\";
        public static string Add(IFormFile file)
        {
            string fileExtension = Path.GetExtension(file.FileName);
            var newPath = Guid.NewGuid().ToString() + fileExtension;
            if (file.Length > 0)
            {
                using (var stream = File.Create(directory + folderName + newPath))
                {
                    file.CopyTo(stream);
                    stream.Flush();
                }
            }

            return (folderName + newPath).Replace("\\","/");
        }
        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(directory + path);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
        public static string Update(string sourcePath, IFormFile file)
        {
            Delete(sourcePath);
            return Add(file);
        }


    }
}
