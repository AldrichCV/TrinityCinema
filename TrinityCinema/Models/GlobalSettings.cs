using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCinema.Models
{
    public class GlobalSettings
    {
        //public static string connectionString = @"Data Source=LAB1-PC12;Initial Catalog=CinemaDB;User=sa;Password=123456";
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CinemaDB;Integrated Security=True";
        //public static string connectionString = @"Data Source=AAA\SQLEXPRESS;Initial Catalog=CinemaDB;Integrated Security=True";

        #region AccountsSQL

        #region Select Queries
        public static string loginQuery = @"SELECT s.Role, a.UserID
                                        FROM [Users] 
                                        WHERE UserName = @User 
                                        AND PasswordHash = @Password";


        public static string getPersonnel = @"SELECT  *, 
                                                CASE 
                                                    WHEN IsLocked = 1 THEN 'Locked'
                                                    ELSE 'Active'
                                                END AS IsLockedDisplay FROM [dbo].[Users]";
        public static string getMovie = @"WITH GenreAggregates AS (
                                                                    SELECT 
                                                                        mg.MovieID,
                                                                        STRING_AGG(g.GenreName, ', ') AS GenreList
                                                                    FROM MovieGenres mg
                                                                    JOIN Genre g ON g.GenreID = mg.GenreID
                                                                    GROUP BY mg.MovieID
                                                                )
                                                                SELECT
                                                                    m.MovieID,
                                                                    m.Title,
                                                                    ga.GenreList AS GenreName,
                                                                    m.Duration,
                                                                    m.Description,
                                                                    m.DateAdded,
                                                                    m.Status,
                                                                    CASE 
                                                                        WHEN m.Status = 1 THEN 'Available'
                                                                        WHEN m.Status = 0 THEN 'Unavailable'
                                                                        ELSE 'Unknown'
                                                                    END AS StatusDisplay,
                                                                    m.MoviePoster,
                                                                    mr.RatingCode AS ContentRatingCode
                                                                    , mr.RatingID AS ContentRating      
                                                                FROM [CinemaDB].[dbo].[Movies] m
                                                                LEFT JOIN GenreAggregates ga ON m.MovieID = ga.MovieID
                                                                LEFT JOIN MovieRating mr ON mr.RatingID = m.ContentRating
                                    ";

        public static string getTheater = @"SELECT * FROM [dbo].[Theaters]";

        public static string getSeatPrice = @"SELECT * FROM [dbo].[Seats] WHERE TheaterID = @TheaterID";

        public static string getShowtime = @"WITH GenreCTE AS (
                                                SELECT 
                                                    mg.MovieID,
                                                    STRING_AGG(g.GenreName, ', ') AS GenreName
                                                FROM MovieGenres mg
                                                INNER JOIN Genre g ON g.GenreID = mg.GenreID
                                                GROUP BY mg.MovieID
                                            )
                                            SELECT 
                                                s.[ShowtimeID],
                                                s.[MovieID],
                                                m.[Title],
                                                gc.GenreName,
                                                m.[MoviePoster],       
                                                mr.[RatingCode],
                                                s.[TheaterID],
                                                t.[TheaterName],    
                                                s.[Price],
                                                s.[ShowDate],
                                                s.[StartTime],
                                                m.[Duration],
                                                DATEADD(SECOND, 
                                                    DATEDIFF(SECOND, '00:00:00', m.Duration), 
                                                    s.[StartTime]
                                                ) AS EndTime,
                                                ss.[StatusID],
                                                ss.[StatusName] AS StatusDisplay
                                            FROM [CinemaDB].[dbo].[Showtimes] s
                                            LEFT JOIN Movies m 
                                                ON m.MovieID = s.MovieID
                                            LEFT JOIN Theaters t 
                                                ON CAST(t.TheaterID AS VARCHAR) = s.TheaterID
                                            LEFT JOIN ShowtimeStatus ss
                                                ON ss.StatusID = s.Status
                                            LEFT JOIN MovieRating mr
                                                ON mr.RatingID = m.ContentRating
                                            LEFT JOIN GenreCTE gc
                                                ON gc.MovieID = m.MovieID ";

        public static string getActivityLog = @"SELECT [LogID]
                                              ,[Timestamp]
                                              ,CASE WHEN u.[Username] IS NULL THEN 'SupaAdmin' ELSE u.Username END AS Username
                                              ,[Action]
                                              ,[Description]
                                          FROM [CinemaDB].[dbo].[ActivityLogs] a
                                          LEFT JOIN Users u
                                          ON u.UserID = a.UserID
                                            ORDER BY [Timestamp] DESC";

        public static string getMovieWithTheater = @"WITH GenreAggregates AS (
                                                                    SELECT 
                                                                        mg.MovieID,
                                                                        STRING_AGG(g.GenreName, ', ') AS GenreList
                                                                    FROM MovieGenres mg
                                                                    JOIN Genre g ON g.GenreID = mg.GenreID
                                                                    GROUP BY mg.MovieID
                                                                )
                                                                SELECT
                                                                    s.TheaterID,
                                                                    t.TheaterName,
                                                                    m.MovieID,
                                                                    m.Title,
                                                                    ga.GenreList AS GenreName,
                                                                    m.Duration,
                                                                    m.Description,
                                                                    m.DateAdded,
                                                                    m.Status,
                                                                    CASE 
                                                                        WHEN m.Status = 1 THEN 'Available'
                                                                        WHEN m.Status = 0 THEN 'Unavailable'
                                                                        ELSE 'Unknown'
                                                                    END AS StatusDisplay,
                                                                    m.MoviePoster,
                                                                    mr.RatingCode AS ContentRatingCode
                                                                    , mr.RatingID AS ContentRating      
                                                                FROM [CinemaDB].[dbo].[Movies] m
                                                                LEFT JOIN GenreAggregates ga ON m.MovieID = ga.MovieID
                                                                LEFT JOIN MovieRating mr ON mr.RatingID = m.ContentRating
                                                                LEFT JOIN Showtimes s ON s.MovieID = m.MovieID
                                                                LEFT JOIN Theaters t ON t.TheaterID = s.TheaterID";


        #endregion

        #region Insert Queries
        public static string insertQuery = @"INSERT INTO [dbo].[Users]
                                           ([UserID]
                                           ,[Username]
                                           ,[PasswordHash]
                                           ,[Fullname]
                                           ,[DateOfBirth]
                                           ,[Role]
                                           ,[Phone]
                                           ,[PersonnelImage]
                                           ,[Status]
                                           ,[DateCreated])

                                     VALUES
                                           (@UserID
                                           ,@Username
                                           ,@PasswordHash
                                           ,@Fullname
                                           ,@DateOfBirth
                                           ,@Role
                                           ,@Phone
                                           ,@PersonnelImage
                                           ,@Status
                                           ,@DateCreated)";

        public static string insertMovieQuery = @"INSERT INTO [dbo].[Movies]
                                                       ([MovieID]
                                                       ,[Title]
                                                       ,[Description]
                                                       ,[Duration]
                                                       ,[Status]
                                                       ,[DateAdded]
                                                       ,[MoviePoster]
                                                       ,[ContentRating])
                                                 VALUES
                                                       (@MovieID
                                                       ,@Title
                                                       ,@Description
                                                       ,@Duration
                                                       ,@Status
                                                       ,@DateAdded
                                                       ,@MoviePoster
                                                       ,@ContentRating);";

        public static string insertNewGenre = @"INSERT INTO [dbo].[Genre]
                                                       ([GenreName])
                                                 VALUES
                                                       (@GenreName);";


        public static string createTheater = @"INSERT INTO [dbo].[Theaters]
                                           ([TheaterName]
                                           ,[SeatCapacity])
                                     VALUES
                                           (@TheaterName
                                           ,@SeatCapacity)";

        public static string insertShowtimeQuery = @"INSERT INTO [dbo].[Showtimes]
                                           (
                                           [MovieID]
                                           ,[Price]
                                           ,[ShowDate]
                                           ,[StartTime]
                                           ,[TheaterID]
                                           ,[Status])
                                     VALUES
                                           (
                                           @MovieID
                                           ,@Price
                                           ,@ShowDate
                                           ,@StartTime
                                           ,@TheaterID
                                           ,@StatusID)";

        public static string insertActivityLog = @"INSERT INTO [dbo].[ActivityLogs]
                                           ([Username]
                                           ,[Action]
                                           ,[DateModified])
                                     VALUES
                                           (@Username
                                           ,@Action
                                           ,@DateModified)";

        #endregion

    

        #endregion of AccountsSQL

    }


}
    