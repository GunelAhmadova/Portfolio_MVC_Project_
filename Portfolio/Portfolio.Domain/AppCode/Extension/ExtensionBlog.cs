using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Extension
{
  public  static partial class ExtensionBlog
    {


        static public string GetImagePhysicalPath(this IHostEnvironment env, string fileName)
        {
            return Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", fileName);
        }
        static public string GetRandomImagePath(this IFormFile file, string prefix = "")
        {
            string extension = Path.GetExtension(file.FileName);//.jpg,.jpeg,

            if (!string.IsNullOrWhiteSpace(prefix))
            {
                prefix = $"{prefix}-";
            }

            return $"{prefix}{Guid.NewGuid()}{extension}".ToLower();
        }

        async static public Task<string> SaveAsync(this IHostEnvironment env, IFormFile file,
            string imageName, CancellationToken cancellationToken)
        {
            string fullPath = env.GetImagePhysicalPath(imageName);

            using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
            {
                await file.CopyToAsync(fs, cancellationToken);
            }

            return fullPath;
        }


        static public string ToSlug(this string context)
        {
            if (string.IsNullOrWhiteSpace(context))
                return null;

            //c#-and-------sql => csharp-and-sql
            context = context.Replace("Ü", "u").Replace("ü", "u")
                .Replace("İ", "i").Replace("I", "i").Replace("ı", "i")
                .Replace("Ş", "s").Replace("ş", "s")
                .Replace("Ö", "o").Replace("ö", "o")
                .Replace("Ç", "c").Replace("ç", "c")
                .Replace("Ğ", "g").Replace("ğ", "g")
                .Replace("Ə", "e").Replace("ə", "e")
                .Replace(" ", "-").Replace("?", "").Replace("/", "")
                .Replace("\\", "").Replace(".", "").Replace("'", "").Replace("#", "sharp").Replace("%", "")
                .Replace("*", "").Replace("!", "").Replace("@", "").Replace("+", "")
                .ToLower().Trim();

            context = Regex.Replace(context, @"\&+", "and");
            context = Regex.Replace(context, @"[^a-z0-9]+", "-");
            context = Regex.Replace(context, @"-+", "-");
            context = context.Trim('-');

            return context;
        }

        static public void ArchiveImage(this IHostEnvironment env, string fileName)
        {
            var imageActualPath = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", fileName);

            if (File.Exists(imageActualPath))
            {
                var imageNewPath = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", $"archive-{DateTime.Now:yyyyMMddHHmmss}-{fileName}");

                File.Move(imageActualPath, imageNewPath);
            }
        }
    }
}
