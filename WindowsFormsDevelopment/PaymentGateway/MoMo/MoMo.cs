﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDevelopment.PaymentGateway.MoMo
{
    public class MoMo
    {
        private string accessKey = ConfigurationManager.AppSettings["accessKey"];
        private string secretKey = ConfigurationManager.AppSettings["secretKey"];
        private string apiEndpoint = ConfigurationManager.AppSettings["apiEndpoint"];

        private string partnerCode = ConfigurationManager.AppSettings["partnerCode"];
        private string partnerName = "Alberthy CoffeeShop";
        private string storeId = "Alberthy_CoffeeShop";
        private string requestId = Guid.NewGuid().ToString();
        private string amount;
        private string orderId;
        private string orderInfo;
        private string redirectUrl = "https://www.ueh.edu.vn/";
        private string ipnUrl = "https://www.ueh.edu.vn/";
        private string requestType = "captureWallet";
        private string extraData = "";
        private string lang = "vi";
        private string signature;

        public MoMo(string amount, string orderInfo, string orderId)
        {
            this.amount = amount;
            this.orderInfo = orderInfo;
            this.orderId = orderId;

            // Raw data before hash
            // Secure transaction in Hmac_SHA256 with format:
            //      a String sort all key name of data field from a-z
            string rawHash =
                "accessKey=" + accessKey +
                "&amount=" + this.amount +
                "&extraData=" + extraData +
                "&ipnUrl=" + ipnUrl +
                "&orderId=" + orderId +
                "&orderInfo=" + this.orderInfo +
                "&partnerCode=" + partnerCode +
                "&redirectUrl=" + redirectUrl +
                "&requestId=" + requestId +
                "&requestType=" + requestType;

            signature = Security.signSHA256(rawHash, secretKey);
        }

        public string GetResponseFromMoMo()
        {
            JObject messageRequest = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", partnerName },
                { "storeId", storeId },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                { "ipnUrl", ipnUrl },
                { "lang", lang },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature }
            };

            string messageResponse = PaymentRequest.SendPaymentRequest(apiEndpoint, messageRequest.ToString());

            return messageResponse;
        }
    }
}
