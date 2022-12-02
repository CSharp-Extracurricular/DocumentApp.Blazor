﻿namespace DocumentApp.Blazor.DTO
{
    public enum Indexator
    {
        RSCI,
        ELibrary,
        Scopus,
        WebOfScience
    }

    public class CitationIndex
    {
        public Guid Id { get; set; }
        public Indexator Indexator { get; set; }
        public Uri URL { get; set; } = null!;

        public Guid PublicationId { get; set; }
    }
}