using OfferHelperV1.ProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.OfferClasses
{
    class TextTemplates
    {
        string producer = @"Оборудование марки Метроном производит / поставляет (продает), обеспечивает гарантийную, постгарантийную и сервисную поддержку, а также является держателем всех сертификатов на оборудование только компания Прайм Тайм.";

        string remark = @"Примечание: В зависимости от сферы применения оборудование может поставляться с определенными опциями (начиная с версии Метроном-300). Опции устанавливаются только при заказе оборудования. Особенно это важно, если нужна поверка http://www.ptime.ru/si.html (меняется название оборудования и обязательное использование опционного внутреннего генератора OCXO-HQ). Ознакомьтесь, пожалуйста, с памяткой: http://www.ptime.ru/Downloads/pamyatka_Metronom.pdf";

        string verificationExample = @"В качестве примера, если нужен Метроном-300 с поверкой, то это будет: Устройство синхронизации частоты и времени Метроном-300/GNS-HQ 2 x NTP LAN Ethernet 10/100, RJ45; 2xRS232, 1x10МГц (TTL), 1x1PPS, генератор OCXO-HQ, эл.пит. ~220В. 6300 Евро с НДС. Антенна ГЛОНАСС/GPS Радиус-50 со встроенным грозоразрядником. 435 Евро с НДС. Антенный кабель 50 м. 140 Евро с НДС. Организация поверки (получение свидетельства о поверке) 500 Евро с НДС. http://www.ptime.ru/Metronom/si/Metronom300si.html Оплата в рублях по курсу ЦБ. Склад Москва 14-16 недель (12 недель + 2-4 недели поверка). 3 года гарантии. (Расширение гарантии до 5 лет +20% к стоимости) Паспорт на изделие. Декларация соответствия ТС (EAC). Свидетельство о поверке.";

        string deliveryText = @"Оплата в рублях по курсу ЦБ. Склад Москва 10-11 недель. Бывает на складе. 3 года гарантии. (Расширение гарантии до 5 лет +20% к стоимости). Паспорт на изделие. Декларация соответствия ТС (EAC).";

        public string Producer { get => producer; set => producer = value; }
        public string Remark { get => remark; set => remark = value; }
        public string VerificationExample { get => verificationExample; set => verificationExample = value; }
        public string DeliveryText { get => deliveryText; set => deliveryText = value; }

        public void LoadTemplates()
        {

        }

        public void SaveTemplates()
        {

        }

        public string GetDeliveryTimeString (int dt, TypeOfProduct t)
        {
            string res="";

            res += @"Оплата в рублях по курсу ЦБ." + Environment.NewLine;
            res += "Склад Москва " + dt.ToString() + " рабочих дней." + Environment.NewLine;
            
            if (t == TypeOfProduct.Server || t == TypeOfProduct.Reciver)
            {
                res += "3 года гарантии. (Расширение гарантии до 5 лет +20% к стоимости)." + Environment.NewLine + "Паспорт на изделие. Декларация соответствия ТС (EAC).";
            }
               
            return res;
        }


    }
}
