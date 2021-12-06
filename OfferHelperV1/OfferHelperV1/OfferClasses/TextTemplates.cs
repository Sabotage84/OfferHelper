using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.OfferClasses
{
    class TextTemplates
    {
        string producer = @"Оборудование марки Метроном производит / поставляет (продает),
                            обеспечивает гарантийную, постгарантийную и сервисную поддержку,
                            а также является держателем всех сертификатов на оборудование
                            только компания Прайм Тайм.";

        string remark = @"Примечание:
                          В зависимости от сферы применения оборудование может поставляться с
                          определенными опциями (начиная с версии Метроном-300).
                          Опции устанавливаются только при заказе оборудования.
                          Особенно это важно, если нужна поверка
                            http://www.ptime.ru/si.html
                          (меняется название оборудования и обязательное использование опционного
                          внутреннего генератора OCXO-HQ).
                          Ознакомьтесь, пожалуйста, с памяткой:
                            http://www.ptime.ru/Downloads/pamyatka_Metronom.pdf";

        public string Producer { get => producer; set => producer = value; }
        public string Remark { get => remark; set => remark = value; }
    }
}
