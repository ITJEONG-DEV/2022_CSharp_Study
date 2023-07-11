using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.호텔_대실
{
    public class Solution
    {
        class Time
        {
            public int hour;
            public int minute;
            public Time(string time)
            {
                var words = time.Split(':');
                hour = int.Parse(words[0]);
                minute = int.Parse(words[1]);
            }
            public Time(int hour, int minute)
            {
                this.hour = hour;
                this.minute = minute;
            }

            public int CompareTo(Time other)
            {
                return (this.hour - other.hour) * 60 + (this.minute - other.minute);
            }

            public override string ToString()
            {
                return $"{hour}:{minute}";
            }
        }
        class Book
        {
            public Time start;
            public Time end;
            public Book(string start, string end)
            {
                this.start = new Time(start);
                this.end = new Time(end);
                this.end.minute += 10;
            }

            public int CompareTo(Book other)
            {
                return this.start.CompareTo(other.start);
            }

            public override string ToString()
            {
                return $"Book({start.ToString()}) ~ ({end.ToString()})";
            }
        }
        class Room
        {
            public List<Book> books;
            public Time endTime;

            public Room()
            {
                this.books = new List<Book>();
            }

            public void Add(Book book)
            {
                this.books.Add(book);

                if (endTime == null || endTime.CompareTo(book.end) < 0)
                    endTime = book.end;
            }

            public override string ToString()
            {
                if (books.Count == 0)
                    return $"Room[0]";
                return $"Room[{books.Count}]: ({books[0].start}) ~ ({endTime})";
            }
        }
        public int solution(string[,] book_time)
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < book_time.GetLength(0); i++)
            {
                Book book = new Book(book_time[i, 0], book_time[i, 1]);
                books.Add(book);
            }

            books.Sort(new Comparison<Book>((b1, b2) => b1.CompareTo(b2)));

            List<Room> rooms = new List<Room>();
            for (int i = 0; i < books.Count; i++)
            {
                Book book = books[i];

                bool add = false;

                for (int j = 0; j < rooms.Count; j++)
                {
                    Room room = rooms[j];

                    if (room.endTime.CompareTo(book.start) <= 0)
                    {
                        room.Add(book);
                        add = true;
                        break;
                    }
                }

                if (!add)
                {
                    Room room = new Room();
                    room.Add(book);
                    rooms.Add(room);
                }
            }

            return rooms.Count;
        }
    }
}
