namespace PhotoAlbum.Models
{
    /// <summary>A single photo or video with a title and caption.</summary>
    public class MediaItem
    {
        public string Title       { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Src         { get; set; } = string.Empty;
        public bool   IsVideo     { get; set; } = false;
    }

    /// <summary>Represents one album page (a folder) with all its media.</summary>
    public class AlbumPage
    {
        public string PageTitle    { get; set; } = string.Empty;
        public string PageSubtitle { get; set; } = string.Empty;
        public string HeroIcon     { get; set; } = "📷";
        public List<MediaItem> Media { get; set; } = new();
    }

    /// <summary>Summary card shown on the Home page for each album section.</summary>
    public class AlbumSection
    {
        public string Name        { get; set; } = string.Empty;
        public string Route       { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CoverImage  { get; set; } = string.Empty;
        public string Icon        { get; set; } = "📷";
    }
}
