namespace WeatherReport.Domain.Service.WeatherReport.Entities
{
    public class WeatherReportEntity
    {
        public int? Id { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Atualizado_em { get; set; }
        public List<Climate>? Clima { get; set; }
    }

    public class Climate
    {
        public string? Data { get; set; }
        public string? Condicao { get; set; }
        public string? Condicao_desc { get; set; }
        public string? Min { get; set; }
        public string? Max { get; set; }
        public string? Indice_uv { get; set; }
    }
}
