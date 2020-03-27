
$('.btn-default').click(function () {
    $('.btn-default').removeClass('ativo');
    $(this).addClass('ativo');
});


function carregagrafico(id) {
  
    var url = "/Home/cadastro/"
    $.ajax({
        type: "POST",
        url: url,
        data: {
            "id": id,
        },
        success: function (data) {

            carregaInformacoes(data);
           
        }


    });


 

}

function carregaInformacoes(response) {
    AmCharts.makeChart("chartdiv",
				{
				    "type": "serial",
				    "categoryField": "date",
				    "dataDateFormat": "YYYY",
				    "theme": "default",
				    "categoryAxis": {
				        "minPeriod": "YYYY",
				        "parseDates": true
				    },
				    "chartCursor": {
				        "enabled": true,
				        "animationDuration": 0,
				        "categoryBalloonDateFormat": "YYYY"
				    },
				    "chartScrollbar": {
				        "enabled": true
				    },
				    "trendLines": [],
				    "graphs": [
						{
						    "bullet": "round",
						    "id": "AmGraph-1",
						    "title": "Total",
						    "valueField": "column-1"
						},
						{
						    "bullet": "square",
						    "id": "AmGraph-2",
						    "title": "E-commerce",
						    "valueField": "column-2"
						},
						{
						    "id": "AmGraph-3",
						    "title": "E-COM CGR",
						    "type": "smoothedLine",
						    "valueField": "column-3"
						}
				    ],
				    "guides": [],
				    "valueAxes": [
						{
						    "id": "ValueAxis-1",
						    "title": ""
						}
				    ],
				    "allLabels": [],
				    "balloon": {},
				    "legend": {
				        "enabled": true,
				        "useGraphSettings": true
				    },
				    "titles": [
						{
						    "id": "Title-1",
						    "size": 15,
						    "text": ""
						}
				    ],
				    "dataProvider": response
				}
			);
}

