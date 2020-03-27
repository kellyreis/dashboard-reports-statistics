am4core.ready(function () {

    // Themes begin
    am4core.useTheme(am4themes_animated);
    // Themes end

    var chart = am4core.create("chartdiv_3", am4charts.SlicedChart);
    chart.paddingBottom = 30;


    chart.data = [{
        "name": "Total Electronic Shopping and Mail-Order Houses (NAICS 45411)",
        "value": 122.4

    }, {
        "name": "Books and magazines",
        "value": 14.4

    }, {
        "name": "Clothing and clothing accessories (includes footwear)",
        "value": 28.8

    }, {
        "name": "Computer hardware",
        "value": 9.4

    }, {
        "name": "Computer software",
        "value": 0

    }, {
        "name": "Drugs, health aids, and beauty aids",
        "value": 32.5

    }, {
        "name": "Electronics and appliances",
        "value": 28.0

    }, {
        "name": "Food, beer, and wine",
        "value": 0

    }, {
        "name": "Furniture and home furnishings",
        "value": 31.8

    }, {
        "name": "Music and videos",
        "value": 0

    }, {
        "name": "Office equipment and supplies",
        "value": 18.7

    }
        , {
            country: "Sporting Goods",
            litres: 0

        }
        , {
            country: "Toys, hobby goods, and games",
            litres: 23.1

        }
        , {
            country: "Other merchandise2",
            litres: 0

        }
        , {
            country: "Nonmerchandise receipts3",
            litres: 32.2

        }


    ];

    var series = chart.series.push(new am4charts.PyramidSeries());
    series.dataFields.value = "value";
    series.dataFields.category = "name";
    series.alignLabels = true;
    series.valueIs = "height";

}); // end am4core.ready()