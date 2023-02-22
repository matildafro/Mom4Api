using System.ComponentModel.DataAnnotations;

namespace Mom4Api.Models {

    public class Album {

        //properties

        public int AlbumId { get; set; }
        //gör albums titel required med DataAnnotations
        [Required]
        public string? AlbumTitle { get; set; }
        public int? Release { get; set; }
        //FK-nyckel och inhämtning av klass
        public int? CommentId { get; set; }

        public Comment? Comment { get; set; }
}

public class Comment {
    public int CommentId { get; set; }

    public string? Grade { get; set; }

    public string? Com { get; set; }
}

public class Song {
        public int SongId { get; set; }
        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? Title { get; set; }
        public int? Length { get; set; }
        public string? Category { get; set; }

        //FK-nyckel och inhämtning av klass
        public int? AlbumId { get; set; }
        public Album? Album { get; set;}
}
}