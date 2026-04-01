using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;
using NUnit.Framework;

public class PortfolioTests : PageTest
{
    private const string URL = "https://adriandotnet.com";

    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync(URL);
    }

    // ... todos os testes aqui dentro ...

    [Test]
    public async Task LinkGitHubExiste()
    {
        var link = Page.Locator("a[href*='github.com']").First;
        await Expect(link).ToBeVisibleAsync();
    }

    [Test]
    public async Task LinkLinkedInExiste()
    {
        var link = Page.Locator("a[href*='linkedin.com']").First;
        await Expect(link).ToBeVisibleAsync();
    }

    [Test]
    public async Task SecaoProjetosVisivel()
    {
        var secao = Page.Locator("#projeto");
        await Expect(secao).ToBeVisibleAsync();
    }

    [Test]
    public async Task ProjetoOrdemServicoListado()
    {
        var body = Page.Locator("body");
        await Expect(body).ToContainTextAsync("PROJETO DE ORDEM E SERVIÇO");
    }
}