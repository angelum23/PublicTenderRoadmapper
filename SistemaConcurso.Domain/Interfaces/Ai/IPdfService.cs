namespace SistemaConcurso.Domain.Interfaces.Ai;

public interface IPdfService
{
    string PdfToString(byte[] pdf);
}