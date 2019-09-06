namespace ProductsCatalog.HttpRequestManager.Parameters
{
    public class UrlParameter
    {
        public UrlParameter(string parameterValue, string parameterName)
        {
            ParameterValue = parameterValue;
            ParameterName = parameterName;
        }

        public string ParameterName { get; set; }

        public string ParameterValue { get; set; }

        public override string ToString()
        {
            return string.Concat(ParameterName, "=", ParameterValue);
        }
    }
}