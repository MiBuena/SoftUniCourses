using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using _01.AutoMapper.DTOs;

namespace _01.AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            CameraContext context = new CameraContext();

            context.Authors.Add(new Author() {Name = "David"});

            context.SaveChanges();

            BookDTO goldenDTO = new GoldenBookDTO()
            {
                AuthorName = "David",
                Name = "Adventure",
                YearOfPublishing = 20
            };

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<BookDTO, Author>();

                cfg.CreateMap<BookDTO, Book>()
                    .Include<GoldenBookDTO, GoldenBook>();

                cfg.CreateMap<GoldenBookDTO, GoldenBook>()
                    .ForMember(x => x.Author,
                        opt =>
                            opt.ResolveUsing(
                                model => context.Authors.FirstOrDefault(x => x.Name == goldenDTO.AuthorName)));

            });

            var mapped = Mapper.Map(goldenDTO, goldenDTO.GetType(), typeof(GoldenBook));




        }
    }
}
