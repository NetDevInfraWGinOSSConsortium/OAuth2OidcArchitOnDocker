//**********************************************************************************
//* �e�X�g�E�R���g���[���[
//**********************************************************************************

// �e�X�g�E�R���g���[���[�Ȃ̂ŁA�K�v�ɉ����ė��p or �폜���ĉ������B

//**********************************************************************************
//* �N���X��        �FValuesController
//* �N���X���{�ꖼ  �F�a�ʊm�F�p
//*
//* �쐬����        �F�|
//* �쐬��          �F���Z
//* �X�V����        �F
//* 
//*  ����        �X�V��            ���e
//*  ----------  ----------------  -------------------------------------------------
//*  2018/09/07  ���� ���         �V�K�쐬
//**********************************************************************************

using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace ReactReduxTemplate.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SampleDataController : ControllerBase
    {
        /// <summary>Summaries</summary>
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        /// GET api/sampledata/weatherforecasts?startDateIndex=1
        /// </summary>
        /// <param name="startDateIndex">int</param>
        /// <returns>IEnumerable(WeatherForecast)</returns>
        [HttpGet()]
        public IEnumerable<WeatherForecast> WeatherForecasts(int startDateIndex)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index + startDateIndex).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        /// <summary>WeatherForecast</summary>
        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}