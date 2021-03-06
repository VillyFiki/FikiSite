﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FikiSite.Models;
using FikiSite.Models.SignModels;

namespace FikiSite.Controllers
{
    public class AuthController : Controller
    {

        List<Sign> testlist = new List<Sign> { new Sign { Name = "Name1", Text = "Следует отметить, что выбранный нами инновационный путь, в своём классическом представлении, допускает внедрение инновационных методов управления процессами. Лишь непосредственные участники технического прогресса подвергнуты целой серии независимых исследований. Следует отметить, что перспективное планирование предоставляет широкие возможности для инновационных методов управления процессами."},
                                            new Sign { Name = "Name2", Text = "Лишь диаграммы связей будут представлены в исключительно положительном свете. Представители современных социальных резервов могут быть в равной степени предоставлены сами себе. Следует отметить, что повышение уровня гражданского сознания требует определения и уточнения системы массового участия."},
                                            new Sign { Name = "Name3", Text = "Вот вам яркий пример современных тенденций - выбранный нами инновационный путь создаёт предпосылки для поставленных обществом задач. Предварительные выводы неутешительны: начало повседневной работы по формированию позиции создаёт предпосылки для направлений прогрессивного развития. Сложно сказать, почему сделанные на базе интернет-аналитики выводы неоднозначны и будут рассмотрены исключительно в разрезе маркетинговых и финансовых предпосылок."},
                                            new Sign { Name = "Name4", Text = "В частности, синтетическое тестирование создаёт необходимость включения в производственный план целого ряда внеочередных мероприятий с учётом комплекса благоприятных перспектив. Как принято считать, сделанные на базе интернет-аналитики выводы, которые представляют собой яркий пример континентально-европейского типа политической культуры, будут ограничены исключительно образом мышления. Учитывая ключевые сценарии поведения, перспективное планирование прекрасно подходит для реализации укрепления моральных ценностей."},
                                            new Sign { Name = "Name5", Text = "Банальные, но неопровержимые выводы, а также сделанные на базе интернет-аналитики выводы неоднозначны и будут объективно рассмотрены соответствующими инстанциями. Тщательные исследования конкурентов превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. В частности, глубокий уровень погружения позволяет оценить значение вывода текущих активов."},
                                            new Sign { Name = "Name6", Text = "И нет сомнений, что сторонники тоталитаризма в науке набирают популярность среди определенных слоев населения, а значит, должны быть смешаны с не уникальными данными до степени совершенной неузнаваемости, из-за чего возрастает их статус бесполезности. Противоположная точка зрения подразумевает, что стремящиеся вытеснить традиционное производство, нанотехнологии будут смешаны с не уникальными данными до степени совершенной неузнаваемости, из-за чего возрастает их статус бесполезности. В своём стремлении повысить качество жизни, они забывают, что экономическая повестка сегодняшнего дня напрямую зависит от первоочередных требований." },
                                            new Sign { Name = "Name7", Text = "Но дальнейшее развитие различных форм деятельности представляет собой интересный эксперимент проверки существующих финансовых и административных условий! Не следует, однако, забывать, что базовый вектор развития создаёт предпосылки для соответствующих условий активизации. Являясь всего лишь частью общей картины, многие известные личности в равной степени предоставлены сами себе." },
                                            new Sign { Name = "Name8", Text = "С другой стороны, существующая теория выявляет срочную потребность новых предложений. Противоположная точка зрения подразумевает, что диаграммы связей набирают популярность среди определенных слоев населения, а значит, должны быть подвергнуты целой серии независимых исследований. Внезапно, многие известные личности формируют глобальную экономическую сеть и при этом - призваны к ответу." },
                                            new Sign { Name = "Name9", Text = "Приятно, граждане, наблюдать, как стремящиеся вытеснить традиционное производство, нанотехнологии разоблачены. Лишь сторонники тоталитаризма в науке, превозмогая сложившуюся непростую экономическую ситуацию, призваны к ответу. Мы вынуждены отталкиваться от того, что новая модель организационной деятельности предполагает независимые способы реализации распределения внутренних резервов и ресурсов." },
                                            new Sign { Name = "Name10", Text = "Прежде всего, социально-экономическое развитие прекрасно подходит для реализации соответствующих условий активизации. Таким образом, существующая теория предоставляет широкие возможности для экономической целесообразности принимаемых решений. В рамках спецификации современных стандартов, многие известные личности являются только методом политического участия и обнародованы!" },};

        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Sign> list = Sign.Shuffle(testlist);
            
            string test = "gegerwjhrtk";

            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
