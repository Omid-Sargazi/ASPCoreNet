﻿using Microsoft.EntityFrameworkCore;
using Season4.Data;
using Season4.Models;

public class Program
{
    public static void Main(string[] args)
    {
        using(var db = new AppDbContext())
        {
            var user = new User{Name = "Alice"};
            user.Profile = new UserProfile {Bio = "Software Developer"};

            db.Users.Add(user);
            db.SaveChanges();

            var fetcheUser = db.Users.Include(u => u.Profile).FirstOrDefault();
            Console.WriteLine($"{fetcheUser.Name} has a profile with the bio: {fetcheUser.Profile.Bio}");

            var book = new Book {Title = "Entity Framework Core", Author = "Jon Smith"};
            book.Reviews.Add(new Review {Reviewer = "John", Rating=5});
            book.Reviews.Add(new Review{Reviewer = "Alice", Rating=3});

            db.Books.Add(book);
            db.SaveChanges();

            var fetcheBook = db.Books.Include(b => b.Reviews).FirstOrDefault();
            Console.WriteLine($"{fetcheBook.Title} has {fetcheBook.Reviews.Count} reviews.");

            var student = new Student {Name = "Mike"};
            var course1 = new Course{CourseName = "C# Advanced"};
            var course2 = new Course {CourseName = "EfCore advanced"};
            student.Courses.Add(course1);
            student.Courses.Add(course2);

            db.Students.Add(student);
            db.SaveChanges();

            var fetchedStudent = db.Students.Include(s => s.Courses).FirstOrDefault();
            Console.WriteLine($"{fetchedStudent.Name} is enrolled in {fetchedStudent.Courses.Count} courses.");

            var otherBook = new Book {Title = "Mastering EF Core", Author = "John Doe"};
            db.Books.Add(otherBook);
            db.SaveChanges();


            using var transaction = db.Database.BeginTransaction();

            try{
                var AliceBook = new Book {Title = "EF Core Transactions", Author="Alice"};
                db.Books.Add(AliceBook);
                db.SaveChanges();

                var review = new Review {Reviewer = "John", Rating = 5, BookId = AliceBook.BookId};
                db.Reviews.Add(review);
                db.SaveChanges();

                transaction.Commit();
                Console.WriteLine("Transaction committed successfully!");



            }catch(Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine($"Transaction failed: {ex.Message}");
            }

            try
            {
                db.Database.ExecuteSqlRaw("INSERT INTO Books (Title, Author) VALUES ('Raw SQL Book', 'SQL Expert')");
                db.Database.ExecuteSqlRaw("INSERT INTO Reviews (Reviewer, Rating, BookId) VALUES ('John', 5, (SELECT MAX(BookId) FROM Books))");
                transaction.Commit();
                Console.WriteLine("Transaction committed using raw SQL.");
            }catch(Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine($"Transaction failed: {ex.Message}");
            }
        }
    }
}