<?php


include "Main.php";

curl_setopt_array($curl, array(
  CURLOPT_URL => 'https://asset_api_test.param.com.tr:5443/api/v1/Exchange/Exchange',
  CURLOPT_RETURNTRANSFER => true,
  CURLOPT_ENCODING => '',
  CURLOPT_MAXREDIRS => 10,
  CURLOPT_TIMEOUT => 0,
  CURLOPT_FOLLOWLOCATION => true,
  CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
  CURLOPT_SSL_VERIFYPEER=>false,
  CURLOPT_CUSTOMREQUEST => 'PUT',
  CURLOPT_POSTFIELDS =>'{
  "customerNumber": "6371501024091642",
  "fromCurrency": "TRY",
  "toCurrency": "EUR",
  "quantity": 10,
  "rate": 9.2922,
  "ticket": "uxg3uLgRpvtoLJbLN1YynTJPKtgN8a/RPfwDL09p3W7mIV7EeJTsIHWqdYMF+Q3KE2UDPFVaCnBqQDcCEJwcp+B9Tsgbn/HjO+5tcfSAGI8eWswMsVq+reqR+NnZ/7P6FeEnfCq6EsAcE7RDZoyzoCQwqdnz7tVstwTkV2l2pNpJYiVc+hhXYeRf6cKweAJp2koO2WKfIgNm2A6w9bAfwii6p/fPhpP1R0lpAYa/b/9Dca1pmBFygzY5w1sHMG+U8iMjmyI64aBBf7pPJWwc3soAFuLdqDfJPLBw55TLlwoybCZkBPLtyVaw1iVjovukK7Y1Et/gQ0h/sKMxPXyYSFaL08juLzU1Fc+4oUFuho57y53EwnO2Fkb1ApMgp/uvgNU7F3zICnfGO3sVKRFYfbg3cm283kt++8qjX/dso8aAx9xSS9HY86uDKQ4k8t5Bjhu+PkVgb2Dvt+Wg1buIXACjb16V63ny99OTyH05CU6eb8e/nFMiulrZRaerwPsF"
}',
  CURLOPT_HTTPHEADER => array(
    'Content-Type: application/json;charset=utf-8',
    'Authorization: Bearer '.$BearerTOKEN
  ),
));

if(curl_exec($curl) === false)
{
    echo 'Curl error: ' . curl_error($curl);
}else{
    $response = curl_exec($curl);
  
    resultView($response);
}

curl_close($curl);
