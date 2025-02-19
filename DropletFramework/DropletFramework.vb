Imports System
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class DropletFramework
    Private BaseUrl As String = "http://api.weatherapi.com/v1"
    Private APIKey As String = "8e121ecd3be648fa95824416251302"
    Private currentUrl As String = "/current.json"
    Private forecastUrl As String = "/forecase.json"

    Public Sub New()

    End Sub

    Public Async Function getApiResponse(ByVal extension As String) As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(BaseUrl & extension)
                response.EnsureSuccessStatusCode()
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Console.WriteLine(responseBody)
            Catch ex As Exception
                Console.WriteLine("Request failed! - ", {ex.Message})
            End Try
        End Using
    End Function


End Class



Public Class Location
    Private _name As String
    Private _region As String
    Private _country As String
    Private _lat As Double
    Private _lon As Double
    Private _tz_id As String
    Private _localtime_epoch As Integer
    Private _localtime As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal name As String, ByVal region As String, ByVal country As String, ByVal lat As Double, ByVal lon As Double, ByVal tz_id As String, ByVal localtime_epoch As Integer, ByVal localtime As String)
        _name = name
        _region = region
        _country = country
        _lat = lat
        _lon = lon
        _tz_id = tz_id
        _localtime_epoch = localtime_epoch
        _localtime = localtime
    End Sub

    <JsonProperty("name")>
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    <JsonProperty("region")>
    Public Property Region As String
        Get
            Return _region
        End Get
        Set(value As String)
            _region = value
        End Set
    End Property

    <JsonProperty("country")>
    Public Property Country As String
        Get
            Return _country
        End Get
        Set(value As String)
            _country = value
        End Set
    End Property

    <JsonProperty("lat")>
    Public Property Lat As Double
        Get
            Return _lat
        End Get
        Set(value As Double)
            _lat = value
        End Set
    End Property

    <JsonProperty("lon")>
    Public Property Lon As Double
        Get
            Return _lon
        End Get
        Set(value As Double)
            _lon = value
        End Set
    End Property

    <JsonProperty("tz_id")>
    Public Property Tz_id As String
        Get
            Return _tz_id
        End Get
        Set(value As String)
            _tz_id = value
        End Set
    End Property

    <JsonProperty("localtime_epoch")>
    Public Property Localtime_epoch As Integer
        Get
            Return _localtime_epoch
        End Get
        Set(value As Integer)
            _localtime_epoch = value
        End Set
    End Property

    <JsonProperty("localtime")>
    Public Property Localtime As String
        Get
            Return _localtime
        End Get
        Set(value As String)
            _localtime = value
        End Set
    End Property



End Class

Public Class Current
    Private _last_updated_epoch As Integer
    Private _last_update As String
    Private _temp_c As Decimal
    Private _temp_f As Decimal
    Private _is_day As Integer
    Private _conditon As Condition
    Private _wind_mph As Decimal
    Private _wind_kph As Decimal
    Private _wind_degree As Integer
    Private _wind_dir As String
    Private _pressure_mb As Decimal
    Private _pressure_in As Decimal
    Private _precip_mm As Decimal
    Private _precip_in As Decimal
    Private _humditiy As Integer
    Private _cloud As Integer
    Private _feelslike_c As Decimal
    Private _feelslike_f As Decimal
    Private _windchill_c As Decimal
    Private _windchill_f As Decimal
    Private _heatindex_c As Decimal
    Private _heatindex_f As Decimal
    Private _dewpoint_c As Decimal
    Private _dewpoint_f As Decimal
    Private _vis_km As Decimal
    Private _vis_miles As Decimal
    Private _uv As Decimal
    Private _gust_mph As Decimal
    Private _gust_kph As Decimal
    Private _air_quality As AirQuality

    Public Sub New()

    End Sub

    <JsonProperty("last_updated_epoch")>
    Public Property last_updated_epoch As Integer
        Get
            Return last_updated_epoch
        End Get
        Set(value As Integer)
            _last_updated_epoch = value
        End Set
    End Property

    <JsonProperty("last_update")>
    Public Property last_update As String
        Get
            Return _last_update
        End Get
        Set(value As String)
            _last_update = value
        End Set
    End Property

    <JsonProperty("_temp_c")>
    Public Property temp_c As Decimal
        Get
            Return _temp_c
        End Get
        Set(value As Decimal)
            _temp_c = value
        End Set
    End Property

    <JsonProperty("_temp_f")>
    Public Property temp_f As Decimal
        Get
            Return _temp_f
        End Get
        Set(value As Decimal)
            _temp_f = value
        End Set
    End Property

    <JsonProperty("_is_day")>
    Public Property is_day As Integer
        Get
            Return _is_day
        End Get
        Set(value As Integer)
            _is_day = value
        End Set
    End Property

    <JsonProperty("condition")>
    Public Property condition As Condition
        Get
            Return _conditon
        End Get
        Set(value As Condition)
            _conditon = condition
        End Set
    End Property

    <JsonProperty("wind_mph")>
    Public Property wind_mph As Decimal
        Get
            Return _wind_mph
        End Get
        Set(value As Decimal)
            _wind_mph = value
        End Set
    End Property

    <JsonProperty("wind_kph")>
    Public Property wind_kph As Decimal
        Get
            Return _wind_kph
        End Get
        Set(value As Decimal)
            _wind_kph = value
        End Set
    End Property

    <JsonProperty("wind_degree")>
    Public Property wind_degree As Integer
        Get
            Return _wind_degree
        End Get
        Set(value As Integer)
            _wind_degree = value
        End Set
    End Property

    <JsonProperty("wind_dir")>
    Public Property wind_dir As String
        Get
            Return _wind_dir
        End Get
        Set(value As String)
            _wind_dir = value
        End Set
    End Property

    <JsonProperty("pressure_mb")>
    Public Property pressure_mb As Decimal
        Get
            Return _pressure_mb
        End Get
        Set(value As Decimal)
            _pressure_mb = value
        End Set
    End Property

    <JsonProperty("pressure_in")>
    Public Property pressure_in As Decimal
        Get
            Return _pressure_in
        End Get
        Set(value As Decimal)
            _pressure_in = value
        End Set
    End Property

    <JsonProperty("precip_mm")>
    Public Property precip_mm As Decimal
        Get
            Return _precip_mm
        End Get
        Set(value As Decimal)
            _precip_mm = value
        End Set
    End Property

    <JsonProperty("precip_in")>
    Public Property precip_in As Decimal
        Get
            Return _precip_in
        End Get
        Set(value As Decimal)
            _precip_in = value
        End Set
    End Property

    <JsonProperty("humidity")>
    Public Property humidity As Integer
        Get
            Return _humditiy
        End Get
        Set(value As Integer)
            _humditiy = value
        End Set
    End Property

    <JsonProperty("cloud")>
    Public Property cloud As Integer
        Get
            Return _cloud
        End Get
        Set(value As Integer)
            _cloud = value
        End Set
    End Property

    <JsonProperty("feelslike_c")>
    Public Property feelslike_c As Decimal
        Get
            Return _feelslike_c
        End Get
        Set(value As Decimal)
            _feelslike_c = value
        End Set
    End Property

    <JsonProperty("feelslike_f")>
    Public Property feelslike_f As Decimal
        Get
            Return _feelslike_f
        End Get
        Set(value As Decimal)
            _feelslike_f = value
        End Set
    End Property

    <JsonProperty("windchill_c")>
    Public Property windchill_c As Decimal
        Get
            Return _windchill_c
        End Get
        Set(value As Decimal)
            _windchill_c = value
        End Set
    End Property

    <JsonProperty("windchill_f")>
    Public Property windchill_f As Decimal
        Get
            Return _windchill_f
        End Get
        Set(value As Decimal)
            _windchill_f = value
        End Set
    End Property

    <JsonProperty("heatindex_c")>
    Public Property heatindex_c As Decimal
        Get
            Return _heatindex_c
        End Get
        Set(value As Decimal)
            _heatindex_c = value
        End Set
    End Property

    <JsonProperty("heatindex_f")>
    Public Property heatindex_f As Decimal
        Get
            Return _heatindex_f
        End Get
        Set(value As Decimal)
            _heatindex_f = value
        End Set
    End Property

    <JsonProperty("dewpoint_c")>
    Public Property dewpoint_c As Decimal
        Get
            Return _dewpoint_c
        End Get
        Set(value As Decimal)
            _dewpoint_c = value
        End Set
    End Property

    <JsonProperty("dewpoint_f")>
    Public Property dewpoint_f As Decimal
        Get
            Return _dewpoint_f
        End Get
        Set(value As Decimal)
            _dewpoint_f = value
        End Set
    End Property

    <JsonProperty("vis_km")>
    Public Property vis_km As Decimal
        Get
            Return _vis_km
        End Get
        Set(value As Decimal)
            _vis_km = value
        End Set
    End Property

    <JsonProperty("vis_miles")>
    Public Property vis_miles As Decimal
        Get
            Return _vis_miles
        End Get
        Set(value As Decimal)
            _vis_miles = value
        End Set
    End Property

    <JsonProperty("uv")>
    Public Property uv As Decimal
        Get
            Return _uv
        End Get
        Set(value As Decimal)
            _uv = value
        End Set
    End Property

    <JsonProperty("gust_mph")>
    Public Property gust_mph As Decimal
        Get
            Return _gust_mph
        End Get
        Set(value As Decimal)
            _gust_mph = value
        End Set
    End Property

    <JsonProperty("gust_kph")>
    Public Property gust_kph As Decimal
        Get
            Return _gust_kph
        End Get
        Set(value As Decimal)
            _gust_kph = value
        End Set
    End Property

    <JsonProperty("air_quality")>
    Public Property air_quality As AirQuality
        Get
            Return _air_quality
        End Get
        Set(value As AirQuality)
            _air_quality = value
        End Set
    End Property


End Class

Public Class Condition
    Private _text As String
    Private _icon As String
    Private _code As Integer

    Public Sub New()

    End Sub

    <JsonProperty("text")>
    Public Property text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property

    <JsonProperty("icon")>
    Public Property icon As String
        Get
            Return _icon
        End Get
        Set(value As String)
            _icon = value
        End Set
    End Property

    <JsonProperty("code")>
    Public Property code As Integer
        Get
            Return _code
        End Get
        Set(value As Integer)
            _code = value
        End Set
    End Property

End Class

Public Class AirQuality
    Private _co As Decimal
    Private _no2 As Decimal
    Private _o3 As Decimal
    Private _so2 As Decimal
    Private _pm2_5 As Decimal
    Private _pm10 As Decimal
    Private _us_epa_index As Integer
    Private _gb_defra_index As Integer

    Public Sub New()

    End Sub

    <JsonProperty("co")>
    Public Property co As Decimal
        Get
            Return _co
        End Get
        Set(value As Decimal)
            _co = value
        End Set
    End Property

    <JsonProperty("no2")>
    Public Property no2 As Decimal
        Get
            Return _no2
        End Get
        Set(value As Decimal)
            _no2 = value
        End Set
    End Property

    <JsonProperty("o3")>
    Public Property o3 As Decimal
        Get
            Return _o3
        End Get
        Set(value As Decimal)
            _o3 = value
        End Set
    End Property

    <JsonProperty("so2")>
    Public Property so2 As Decimal
        Get
            Return _so2
        End Get
        Set(value As Decimal)
            _so2 = value
        End Set
    End Property

    <JsonProperty("pm2_5")>
    Public Property pm2_5 As Decimal
        Get
            Return _pm2_5
        End Get
        Set(value As Decimal)
            _pm2_5 = value
        End Set
    End Property

    <JsonProperty("pm10")>
    Public Property pm10 As Decimal
        Get
            Return _pm10
        End Get
        Set(value As Decimal)
            _pm10 = value
        End Set
    End Property

    <JsonProperty("us-epa-index")>
    Public Property us_epa_index As Integer
        Get
            Return _us_epa_index
        End Get
        Set(value As Integer)
            _us_epa_index = value
        End Set
    End Property

    <JsonProperty("gb-defra-index")>
    Public Property gb_defra_index As Integer
        Get
            Return _gb_defra_index
        End Get
        Set(value As Integer)
            _gb_defra_index = value
        End Set
    End Property

End Class

Public Class Forecast
    Private _forecastday As List(Of Forecastday)
    Public Sub New()

    End Sub

    <JsonProperty("forecastday")>
    Public Property forecastday As List(Of Forecastday)
        Get
            Return _forecastday
        End Get
        Set(value As List(Of Forecastday))
            _forecastday = value
        End Set
    End Property


End Class

Public Class Forecastday
    Private _date As String
    Private _date_epoch As Integer
    Private _day As List(Of Day)

    Public Sub New()

    End Sub

End Class

Public Class Day

End Class