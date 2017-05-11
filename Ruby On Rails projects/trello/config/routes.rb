Rails.application.routes.draw do

  resources :postits

  root 'postits#new'
  get 'postits/:id'   =>  'postits#show'
  # post '/notes/update_order' => 'notes#update_all_orders'
  # postits GET    /postits(.:format)          'postits#index'

  # For details on the DSL available within this file, see http://guides.rubyonrails.org/routing.html
end
