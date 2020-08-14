import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatCardModule } from '@angular/material';
import { CharacterCardComponent } from './character-card/character-card.component';
import { CharacterService } from './services/character.service';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [CharacterCardComponent],
  imports: [
    CommonModule,
    MatCardModule,
    HttpClientModule
  ],
  exports: [
    MatCardModule,
    CharacterCardComponent
  ],
  providers: [
    CharacterService
  ]
})
export class SharedModule { 
}
