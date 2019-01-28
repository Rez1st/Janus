using Model.Janus.Core;

namespace Model.Janus.Sql
{
    public class HumanResource
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string LinkedLink { get; set; }

        public ProgrammingLanguage MainProgrammingLanguage { get; set; }

        public ForeignLanguage NativeLanguage { get; set; }

        public EnglishLivel EnglishLevel { get; set; }
    }
}
