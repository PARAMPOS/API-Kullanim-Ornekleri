<style>
table {
  font-family: arial, sans-serif;
}

td, th {
  border: 1px solid #dddddd;
  text-align: left;
  padding: 8px;
}

tr:nth-child(even) {
  background-color: #dddddd;
}
table{
    table-layout: fixed;
}
td{
    word-wrap:break-word
}
</style>


<?php

function resultView($response){

    if($response==null){
        echo "Response boş.";
        return;
    }

    $responseJsonDecode=json_decode($response, true);
    print_r(_arrayToHtmlTableRecursive($responseJsonDecode));
}

function _arrayToHtmlTableRecursive($arr) {
    $str = "<table><tbody>";
    foreach ($arr as $key => $val) {
        $str .= "<tr>";
        $str .= "<td><strong>$key</strong></td>";
        $str .= "<td>";
        if (is_array($val)) {
            if (!empty($val)) {
                $str .= _arrayToHtmlTableRecursive($val);
            }
        } else {
            $str .= "<u>$val</u>";
        }
        $str .= "</td></tr>";
    }
    $str .= "</tbody></table>";

    return $str;
}


?>