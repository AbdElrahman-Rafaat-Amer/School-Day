import { Assginment } from './../assignment/assginment';
import { Pipe, PipeTransform } from '@angular/core';
import { servicesVersion } from 'typescript';

@Pipe({
  name: 'searchfilter'
})

export class SearchfilterPipe implements PipeTransform {
  transform(Assginment:Assginment[]|null,_searchValue:string): Assginment[] {
    if(!Assginment || ! _searchValue){
      return Assginment as any;
    }
    return Assginment.filter(Assginment =>
      Assginment.ContentTitle.toLocaleLowerCase().includes(_searchValue.toLocaleLowerCase()));
  }

}
