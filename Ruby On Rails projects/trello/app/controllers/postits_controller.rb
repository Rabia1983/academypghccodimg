class PostitsController < ApplicationController
  def index
    @postit = Postit.all
  end

  def show
    @postit = Postit.find(params[:id])
  end

  def new
    @postit = Postit.new
  end

  def edit
    @postit = Postit.find(params[:id])
  end

  def create
  @postit = Postit.new(postit_params)
  if @postit.save
  redirect_to postit_path(@postit)
  # redirect_to @postit
   else
  render 'new'
  end
   end


  def update
  @postit = Postit.find(params[:id])
  if @postit.update(postit_params)
    redirect_to @postit
  else
    render 'edit'
  end
  end

  # def update_order
  #     # Note.find(params[:id]).update(sort_order: params[:new_order])
  #     note = Note.find(params[:id])
  #     note.sort_order = params[:new_order]
  #     note.save
  #     redirect_to notes_path
  #   end
  #
  #   def update_all_orders
  #     new_order = params[:new_order].split(',')
  #     new_order.each_with_index do |note, i|
  #       note = Note.find(note)
  #       note.sort_order = i
  #       note.save
  #     end
  #     redirect_to notes_path
  # end


  private
  def postit_params
    params.require(:postit).permit(:title, :text)
  end
  end
