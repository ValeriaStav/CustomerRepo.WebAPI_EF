using CustomerManagement.BusinessEntities;
using CustomerManagement.Repositories;
using Xunit;

namespace CustomerManagement.Integration.Tests
{
    public class NoteRepositoryTests
    {
        public NoteRepositoryFixture Fixture => new NoteRepositoryFixture();

        [Fact]
        public void ShouldBeAbleToCreateNoteRepository()
        {
            var repository = new NoteRepository();
            Assert.NotNull(repository);
        }

        [Fact]
        public void ShouldBeAbleToCreateNote()
        {
            Fixture.DeleteAll();
            var repository = new NoteRepository();
            var notes = new Notes()
            {
                CustomerId = 1,
                Note = "Lorem ipsum dolor sit amet."
            };
            repository.Create(notes);

            Assert.NotNull(repository);
        }

        [Fact]
        public void ShouldBeAbleToReadNote()
        {
            Fixture.DeleteAll();
            var noteCustomer = Fixture.CreateNoteRepository().Read(0);
            Assert.Equal(0, noteCustomer.NoteId);
        }

        [Fact]
        public void ShouldNotBeAbleToReadNotes()
        {
            //Fixture.DeleteAll();
            var noteCustomer = Fixture.CreateNoteRepository().Read(0);
            Assert.Null(noteCustomer);
        }

        [Fact]
        public void ShouldBeAbleToUodateNote()
        {
            Fixture.DeleteAll();
            var notes = new Notes()
            {
                NoteId = 79,
                CustomerId = 2,
                Note = "Lorem ipsum dolor sit amet."
            };
            Fixture.CreateNoteRepository().Update(notes);
        }

        [Fact]
        public void ShouldBeAbleToDeleteNote()
        {
            var notes = new Notes()
            {
                CustomerId = 2,
                Note = "Aenean commodo ligula eget dolor."
            };
            Fixture.CreateNoteRepository().Create(notes);
        }
    }

    public class NoteRepositoryFixture
    {
        public void DeleteAll()
        {
            var repository = new NoteRepository();
            repository.DeleteAll();
        }

        public Notes CreateMockNotes()
        {
            var notes = new Notes
            {
                CustomerId = 1,
                Note = "Lorem ipsum dolor sit amet."
            };

            var noteRepository = new NoteRepository();
            noteRepository.Create(notes);
            return notes;
        }
        public NoteRepository CreateNoteRepository()
        {
            return new NoteRepository();
        }
    }
}
