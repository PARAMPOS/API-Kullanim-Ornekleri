<?php

include "Main.php";

curl_setopt_array($curl, array(
  CURLOPT_URL => 'https://asset_api_test.param.com.tr:5443/api/v1/Exchange/ResultCodes?language=en',
  CURLOPT_RETURNTRANSFER => true,
  CURLOPT_ENCODING => '',
  CURLOPT_MAXREDIRS => 10,
  CURLOPT_TIMEOUT => 0,
  CURLOPT_FOLLOWLOCATION => true,
  CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
  CURLOPT_CUSTOMREQUEST => 'GET',
  CURLOPT_SSL_VERIFYPEER=>false,
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