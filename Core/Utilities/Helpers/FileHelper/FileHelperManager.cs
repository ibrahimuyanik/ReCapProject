﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Ioc;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root) // file--> güncellenecek yeni dosya, filePath --> eski dosyanın bulunduğu dizin, root--> güncellenecek dosyanın kayıt dizini
        {

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            return Upload(file, root);
        }

        public string Upload(IFormFile file, string root)
        {
            if (file.Length > 0)
            {

                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }

                string extension = Path.GetExtension(file.FileName);// dosyanın uzantısını aldık .jpg gibi
                string guid = GuidHelper.GuidHelper.CreateGuid(); // guid değeri oluşturduk
                string filePath = guid + extension; // guid değeri ile dosya uzantısını birleştirdik

                using (FileStream fileStream = File.Create(root + filePath))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                    return filePath;
                }

            }

            return null;
        }
    }
}
