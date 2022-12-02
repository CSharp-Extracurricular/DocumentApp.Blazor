namespace DocumentApp.Blazor.DTO
{
    public enum PublicationType
    {
        Monography,
        Textbook,
        Article,
        Report,
        Thesis
    }

    public class Publication
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int PublishingYear { get; set; }
        public PublicationType PublicationType { get; set; }

        // Цифровой идентификатор объекта.
        public string DOI { get; set; } = string.Empty;

        // Идентификатор для группировки идентичных объектов.
        public Guid AuthorGroupId { get; set; }

        // Идентификатор создателя записи.
        public Guid UserId { get; set; }

        public List<Author> Authors { get; set; } = new List<Author>();
        public List<CitationIndex> CitationIndices { get; set; } = new List<CitationIndex>();
        public Conference? Conference { get; set; }
    }
}
