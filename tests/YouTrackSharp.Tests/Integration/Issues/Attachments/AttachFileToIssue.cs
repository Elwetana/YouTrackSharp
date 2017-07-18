using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using YouTrackSharp.Issues;
using YouTrackSharp.Tests.Infrastructure;

// ReSharper disable once CheckNamespace
namespace YouTrackSharp.Tests.Integration.Issues
{
    public partial class IssuesServiceTests
    {
        public class AttachFileToIssue
        {
            [Fact]
            public async Task Valid_Connection_Attaches_Single_File_To_Issue()
            {
                // Arrange
                var connection = Connections.Demo1Token;
                var service = connection.CreateIssuesService();
                
                var issue = new Issue
                {
                    Summary = "Test issue - " + DateTime.UtcNow.ToString("U"),
                    Description = "This is a test issue created while running unit tests."
                };
                
                issue.SetField("State", "Fixed");
                
                var issueId = await service.CreateIssue("DP1", issue);
                
                // Act & Assert
                using (var attachmentStream = await TestUtilities.GenerateAttachmentStream("Generated by unit test."))
                {
                    await service.AttachFileToIssue(issueId, "singlefile.txt", attachmentStream);
                }
            }
        }
    }
}