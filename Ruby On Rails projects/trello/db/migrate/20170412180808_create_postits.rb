class CreatePostits < ActiveRecord::Migration[5.0]
  def change
    create_table :postits do |t|
      t.string :title
      t.text :text

      t.timestamps
    end
  end
end
