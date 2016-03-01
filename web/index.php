<!DOCTYPE html>
<html>
<head>
	<title>Scrum Notes</title>
	<script src='http://projects.josephmorrill.com/library/versions/latest.js'></script>
	<meta name='viewport' content='initial-scale=1'>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css">
	<script>
	var notes = {
		"create" : function(){
			getJSON( 'api.php?action=create', true, function( data ){
				notes.show( data.id, "" );
			} );
		},
		"update" : function( note ){
			var note_id = $.get( note, 'id' );
			var note_content = note.getElementsByClassName( 'note' )[0];
			$.set( note, 'status', 'updating' );
			getText( "api.php?action=update&id=" + note_id + "&content=" + encodeURIComponent( note_content.value ), false, function(){
				// Request finished, so change note status to not updating
				$.set( note, 'status', 'updated' );
			} );
		},
		"delete" : function( note ){

			var note_id = $.get( note, 'id' );
			getJSON( 'api.php?action=delete&id=' + note_id, true, function( data ){
				$.delete( note );
			} );
		},
		"show" : function( id, content ){
			var note_wrapper = $.new( 'div', {
				'class' : 'note-wrapper',
				'id' : 'note' + id,
				'data-id' : id,
				'parent' : 'notes'
			} );
			var note = $.new( 'textarea', {
				'class' : 'note',
				'parent' : note_wrapper,
				'onkeyup' : 'notes.update( this.parentNode );',
				'value' : content
			} );
			var note_delete = $.new( 'button', {
				'class' : 'note-delete',
				'type' : 'button',
				'onclick' : 'notes.delete( this.parentNode );',
				'html' : "<i class='fa fa-ban'></i>",
				'parent' : note_wrapper
			} );
		},
		"list" : function(){
			getJSON( 'api.php?action=list', true, function( data ){
				for( var i = 0; i < data.length; i++ ){
					var note = data[i];
					try{
						notes.show( note.id, note.content );
					}catch(e){

					}
				}
			} );
		},
		"watch" : function(){
			getJSON( 'api.php?action=list', true, function handleWatchResult( data ){
				for( var i = 0; i < data.length; i++ ){
					try{
						var db_note = data[i];
						var display_note = $.id( 'note' + db_note.id );
						if( display_note == null ){
							// Note is new, so show
							notes.show( db_note.id, db_note.content );
						}else{
							var display_note_editor = display_note.getElementsByClassName( 'note' )[0];
							display_note_editor.value = db_note.content;
						}
					}catch(e){

					}
				}
			} );
		}
	}
	</script>
	<style>
	/* Styling from http://cssdeck.com/labs/css3-sticky-note */
	@import url(http://fonts.googleapis.com/css?family=Gloria+Hallelujah);
	body{
		background:url(cork.jpg);
	}
	.note-wrapper{
		display:inline-block;
		margin:20px;
		position:relative;
		z-index:1;
	}
	.note{
		box-sizing:border-box;
		background-color:#F9EFAF;
		outline:0px;
		font-size:18px;
		font-family:'Gloria Hallelujah', cursive, Lucida Handwriting, Lucida, Cambria, serif;
		padding:30px 20px 15px 20px;
		min-height:200px;
		min-width:200px;
		width:210px;
		line-height:1.5;
		border:0;
		border-radius:3px;
		background:-webkit-linear-gradient(#F9EFAF, #F7E98D);
		background:-moz-linear-gradient(#F9EFAF, #F7E98D);
		background:-o-linear-gradient(#F9EFAF, #F7E98D);
		background:-ms-linear-gradient(#F9EFAF, #F7E98D);
		background-repeat:no-repeat;
		background-position:center;
		background:url( pin.png ), linear-gradient(#F9EFAF, #F7E98D);
		background-repeat:no-repeat, no-repeat;
		background-position:center -1px, center;
		box-shadow:0 4px 6px rgba(0,0,0,0.1);
		box-shadow:1px 1px 5px black;
		overflow:hidden;
		resize:both;
		z-index:1;
	}
	.note-delete{
		display:none;
		position:absolute;
		top:10px;
		right:10px;
		color:red;
		padding:2px;
		z-index:2;
		font-size:18px;
		cursor:pointer;
	}
	.note-wrapper:hover .note-delete{
		display:block;
	}
	button{
		font-size:20px;
		padding:4px 6px;
	}
	</style>
</head>
<body>
	<div style='text-align:center;'>
		<button type='button' id='add-note' onclick='notes.create();'><i class='fa fa-plus' style='color:green;'></i> Add note</button>
		<button type='button' id='watch-notes' onclick='notes.watch();'><i class='fa fa-refresh'></i> Refresh</button>
	</div>
	<div id='notes'>

	</div><!-- #notes -->
	<script>
	setInterval( notes.watch, 1500 );
	</script>
</body>
</html>