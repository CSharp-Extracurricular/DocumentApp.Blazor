using DocumentApp.Domain;

namespace DocumentApp.Blazor
{
    public static class Localization
    {
        public static string Translate(PublicationType type)
        {
            switch (type)
            {
                case PublicationType.Article: return "Статья";
                case PublicationType.Textbook: return "Учебник";
                case PublicationType.Thesis: return "Доклад";
                case PublicationType.Report: return "Отчёт";
                case PublicationType.Monography: return "Монография";
                default: return "Неизвестно";
            }
        }

        public static string Translate(PublicationStatus status)
        {
            switch (status)
            {
                case PublicationStatus.Draft: return "Черновик";
                case PublicationStatus.Sent: return "Отправлено в редакцию";
                case PublicationStatus.Finalizing: return "На доработке";
                case PublicationStatus.Accepted: return "Принято";
                case PublicationStatus.Published: return "Опубликовано";
                default: return "Неизвестно";
            }
        }
    }
}
