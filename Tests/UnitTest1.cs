using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackBooks;


namespace Tests
{
    [TestClass]
    public class SeralizationTests
    {
        [TestMethod]
        public void TestMethod()
        {
            var dto = new BookRequestDto
            {
                Filled = DateTime.Now,
                FullName = "Тот чье имя нельзя называть",
                BookTitles = new List<BookTitle>()
                {
                    new BookTitle
                    {
                        Book = new List<BookDetails>()
                        {
                            new BookDetails
                            {
                                Title = "Гарри Поттер. Все части",
                                Genre = Genre.HumorousLiterature,
                                PagesNumber = 322,
                                Price = 40000,
                                AgeLimit = AgeLimit.sixAndOlder,
                                Presence = true
                            }
                        }
                    }
                },
                Addres = "Косой переулок",
                Price = 40000,
                Currency = Currency.Bitcoins
            };
            var tempFileName = Path.GetTempFileName();
            try
            {
                BooksDtoHelper.WriteToFile(tempFileName, dto);
                var readDto = BooksDtoHelper.LoadFromFile(tempFileName);
                Assert.AreEqual(dto.FullName, readDto.FullName);
                Assert.AreEqual(dto.Currency, readDto.Currency);
            }
            finally
            {
                File.Delete(tempFileName);
            }
            
        }
    }
}
