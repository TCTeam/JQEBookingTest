$(this).ready(function(e) {
    /*动作条控制*/
	$(".actionbar li").click(function(){
			$(".actionbar li").removeClass("active");
			$(".content").children("div").css("display","none");
			$(this).addClass("active");
			var index =$(".actionbar li").index(this);
			$(".content").children("div:eq("+index+")").show();
		});	
	/*主页导航*/
	$(".contentItem1 .Chandle").click(function(){
			$(".actionbar li").removeClass("active");
			$(".content").children("div").css("display","none");
			var index =$(".contentItem1 .Chandle").index(this)+1;
			$(".actionbar ul").children("li:eq("+index+")").addClass("active");
			$(".content").children("div:eq("+index+")").show();
		});
	$('#Form1').bind('submit', function(){
		    ajaxSubmit(this, function(data){            
				alert(data);       
			});        
			return false;    
	});
});
	function ajaxSubmit(frm, fn) {    
	var dataPara = getFormJson(frm);    
	$.ajax(
	{        
		url: frm.action,        
		type: frm.method,        
		data: dataPara,        
		success: fn    
	});}
	function getFormJson(frm) {
		var o = {};    
		var a = $(frm).serializeArray();    
		$.each(a, function () {        
			if (o[this.name] !== undefined) {            
				if (!o[this.name].push) {                
					o[this.name] = [o[this.name]];
			 	}            
			 o[this.name].push(this.value || '');
			} else {            
			o[this.name] = this.value || '';       
			}    
		});    
		return o;
	}
	