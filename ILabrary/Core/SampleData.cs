using ILabrary.Models.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILabrary.Core
{
    public static class SampleData
    {
        /// <summary>
        /// Get sample data
        /// </summary>
        /// <returns></returns>
        public static IList<Library> GetSampleData() =>
            new List<Library>
            {
                new Library
                {
                    Name = "libra library",
                    Address = "14 joseen, johannesbourg",
                    EmailAddress = "libra@gmail.com",
                    UniqueId = "libra",
                    Users = new List<LibraryUser>
                    {
                        new LibraryUser
                        {
                            FirstName = "john",
                            LastName = "cosmos",
                            Username = "cosmos",
                            Password = "123456789"
                        },
                        new LibraryUser
                        {
                            FirstName = "kali",
                            LastName = "morris",
                            Username = "kali",
                            Password = "123456789"
                        }
                    },
                    Books = new List<Book>
                    {
                        new Book
                        {
                            Name = "python by aris",
                            Barcode = "123456789",
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "9780321699879_ae6a.jpg"
                                }
                            },
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "programming"
                                },
                                new BookTag
                                {
                                    Name = "python"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "master java",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "programming"
                                },
                                new BookTag
                                {
                                    Name = "java"
                                }
                            },
                            Qty = 1,
                            Barcode = "14532551"
                        },
                        new Book
                        {
                            Name = "c++ secret",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "programming"
                                },
                                new BookTag
                                {
                                    Name = "c++"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "c++ in 3 days",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "programming"
                                },
                                new BookTag
                                {
                                    Name = "c++"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "beginning c++ programming",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "programming"
                                },
                                new BookTag
                                {
                                    Name = "c++"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "c++.png"
                                }
                            }
                        }
                    }
                },
                new Library
                {
                    Name = "medecine library wits",
                    Address = "12 jorisson, johannesbourg",
                    UniqueId = "medecine-wits",
                    EmailAddress = "medecine-library-wits@gmail.com",
                    EmailAddress2 = "medecine-library@wits.co.za",
                    Phone = "+27 11 2563 0125",
                    Users = new List<LibraryUser>
                    {
                        new LibraryUser
                        {
                            FirstName = "tom",
                            LastName = "dome",
                            Password = "123456789",
                            Username = "tom"
                        }
                    },
                    Books = new List<Book>
                    {
                        new Book
                        {
                            Name = "Cartiology integrated approach",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "cartiology"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "cover_9780071791540_fc.jpg"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "cardiology indian perspective",
                            Barcode = "10002514122",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "cartiology"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "csi textbook 001-720x1000.jpg"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "neonatal cardiology third edition",
                            Barcode = "745821632",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "cartiology"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "cover_9780071834506_fc.jpg"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "cardiology illustrated",
                            Barcode = "36585255",
                            Qty = 0,
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "cartiology"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "5ac840f39f503fedd7658e3afc664d47_5b88.jpg"
                                }
                            }
                        }
                    }
                },
                new Library
                {
                    Name = "SA library",
                    Address = "121, ave san marion,  johannesbourg",
                    Phone = "+27 11 452 965 01",
                    Phone2 = "+27 11 525 23 65",
                    UniqueId = "sa-library",
                    Users = new List<LibraryUser>
                    {
                        new LibraryUser
                        {
                            FirstName = "tom",
                            LastName = "dome",
                            Password = "123456789",
                            Username = "tom"
                        }
                    },
                    Books = new List<Book>
                    {
                         new Book
                         {
                            Name = "cardiology illustrated",
                            Barcode = "36585255",
                            Qty = 26,
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "cartiology"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "5ac840f39f503fedd7658e3afc664d47_5b88.jpg"
                                }
                            }
                         },
                         new Book
                         {
                            Name = "cardiology indian perspective",
                            Barcode = "10002514122",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "cartiology"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "csi textbook 001-720x1000.jpg"
                                }
                            }
                         },
                         new Book
                         {
                            Name = "c++ secret",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "programming"
                                },
                                new BookTag
                                {
                                    Name = "c++"
                                }
                            }
                         },
                         new Book
                         {
                            Name = "python by aris",
                            Barcode = "123456789",
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "9780321699879_ae6a.jpg"
                                }
                            },
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "programming"
                                },
                                new BookTag
                                {
                                    Name = "python"
                                }
                            }
                         }
                    }
                },
                new Library
                {
                    Name = "jambo library",
                    Address = "32 mokono, sandton, johannesbourg",
                    UniqueId = "jambo",
                    Users = new List<LibraryUser>
                    {
                        new LibraryUser
                        {
                            FirstName = "tom",
                            LastName = "dome",
                            Password = "123456789",
                            Username = "tom"
                        }
                    },
                    Books = new List<Book>
                    {
                        new Book
                        {
                            Name = "master java",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "programming"
                                },
                                new BookTag
                                {
                                    Name = "java"
                                }
                            },
                            Qty = 1,
                            Barcode = "14532551"
                        },
                        new Book
                        {
                            Name = "grain brain",
                            Barcode = "6959323233",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "neurology"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "9a33700d230193866e2a4f47b2fe7f46.jpg"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "Heard desease",
                            Qty = 3,
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "cardiology"
                                },
                                new BookTag
                                {
                                    Name = "desease"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "51x-TYOw6sL._SX393_BO1,204,203,200_.jpg"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "The adolescent brain",
                            Qty = 8,
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "neurology"
                                },
                                new BookTag
                                {
                                    Name = "sabine peters"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "514487_7729683_1531239_6e525f57_image.jpg"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "Collective intelligence",
                            Barcode = "69354622410",
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "71R-ILkOLoL.jpg"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "Networks an introduction",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "networks"
                                },
                                new BookTag
                                {
                                    Name = "M.E.J Newman"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "51iCf6jfQoL._SX376_BO1,204,203,200_.jpg"
                                }
                            }
                        }
                    }
                },
                new Library
                {
                    Name = "central library",
                    Address = "100, av combrige, johannesbourg",
                    UniqueId = "central",
                    EmailAddress = "centralelibrary@gov.co.za",
                    Phone = "+27 11 526 023 14",
                    Phone2 = "+27 11 475 20 13",
                    Users = new List<LibraryUser>
                    {
                        new LibraryUser
                        {
                            FirstName = "tom",
                            LastName = "dome",
                            Password = "123456789",
                            Username = "tom"
                        }
                    },
                    Books = new List<Book>
                    {
                        new Book
                        {
                            Name = "Networks an introduction",
                            Qty = 8,
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "networks"
                                },
                                new BookTag
                                {
                                    Name = "M.E.J Newman"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "51iCf6jfQoL._SX376_BO1,204,203,200_.jpg"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "c++ secret",
                            Qty = 25,
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "programming"
                                },
                                new BookTag
                                {
                                    Name = "c++"
                                }
                            }
                        },
                        new Book
                        {
                            Name = "beginning c++ programming",
                            Tags = new List<BookTag>
                            {
                                new BookTag
                                {
                                    Name = "programming"
                                },
                                new BookTag
                                {
                                    Name = "c++"
                                }
                            },
                            Images = new List<BookPicture>
                            {
                                new BookPicture
                                {
                                    FullPath = "c++.png"
                                }
                            }
                        }
                    }
                }
            };
    }
}
