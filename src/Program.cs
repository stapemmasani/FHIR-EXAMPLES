using System;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;

/// <summary>
/// Main Program
/// </summary>
public static class Program
{
    private const string _fhirServer = "https://server.fire.ly/";
    private const string _fhirServerHappy="https://hapi.fhir.org/baseR4";
    static void Main(string[] args)
    {
        FhirClient fhirClient = new FhirClient(_fhirServerHappy)
        {
            PreferredFormat = ResourceFormat.Json,
            PreferredReturn = Prefer.ReturnRepresentation
        };

        Bundle patientBundle =fhirClient.Search<Patient>(new string[]{"name=test"});

        Console.WriteLine($"Total: {patientBundle.Total} Entry count : {patientBundle.Entry.Count}");

    }
} 